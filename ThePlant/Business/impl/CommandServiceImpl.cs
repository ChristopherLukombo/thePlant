using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business.dto;
using ThePlant.Business.mapper;
using ThePlant.dao;
using ThePlant.Entity;

namespace ThePlant.Business.impl
{
    public class CommandServiceImpl : ICommandService
    {
		private CommandServiceImpl commandServiceImpl = new CommandServiceImpl();

		private ICommandMapper commandMapper = new CommandMapperImplWithList();

		private ICommandDAO commandDAO = Factory.GetCommandDAO();

		private Context context = new Context();

		public CommandServiceImpl()
		{
		}

		public CommandModelDTO SavePayment(CommandModelDTO commandModelDTO)
		{
			CommandModel commandModel = commandMapper.ToEntity(commandModelDTO);
			commandModel.State = new PendingState();
			commandModel.Execute(); // command pending
			return commandMapper.ToDTO(commandDAO.Save(commandModel));
		}

        public CommandModelDTO Pay(CommandModelDTO commandModelDTO)
        {
			CommandModel commandModel = commandMapper.ToEntity(commandModelDTO);
	
			if (commandModel.ChoicePaiment != null && commandModel.ChoicePaiment.Equals("PayPal")) {
				context.paiement = new PaypalServiceImpl();
			} else if (commandModel.ChoicePaiment != null && commandModel.ChoicePaiment.Equals("Cash")) {
				context.paiement = new CashServiceImpl();
			}

			context.Pay();

			commandModel.State = new FinishedState();
			commandModel.Execute(); // command finished
	
			return commandMapper.ToDTO(commandDAO.Update(commandModel));
		}

		public CommandModelDTO Cancel(CommandModelDTO commandModelDTO)
		{
			CommandModel commandModel = commandMapper.ToEntity(commandModelDTO);
			
			commandModel.State = new CanceledState();
			commandModel.Execute(); // command canceled

			return commandMapper.ToDTO(commandDAO.Update(commandModel));
		}
	}
}
