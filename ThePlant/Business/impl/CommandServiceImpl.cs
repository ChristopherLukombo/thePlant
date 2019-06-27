using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business.dto;
using ThePlant.Business.mapper;
using ThePlant.Entity;

namespace ThePlant.Business.impl
{
    public class CommandServiceImpl : ICommandService
    {
   
		private CommandMapper commandMapper = new CommandMapperImpl();

		// Fake repository
		private List<CommandModel> commands = new List<CommandModel>();

	    private Context context = new Context();

		public CommandServiceImpl()
		{
			// Default constructor.
		}

		public CommandModelDTO SavePayment(CommandModelDTO commandModelDTO)
		{
			CommandModel commandModel = commandMapper.ToEntity(commandModelDTO);
			commandModel.State = new PendingState();
			commandModel.Execute(); // command pending

			commands.Add(commandModel);

			return commandMapper.ToDTO(commandModel);
		}

        public CommandModelDTO Pay(CommandModelDTO commandModelDTO)
        {
			CommandModel commandModel = commandMapper.ToEntity(commandModelDTO);
		
			// Design Pattern "strategy" implémenté
			// TODO : Trouver le moyen de refactorer en ajoutant un autre design pattern
			if (commandModel.ChoicePaiment != null && commandModel.ChoicePaiment.Equals("PayPal")) {
				context.paiement = new PaypalServiceImpl();
			} else if (commandModel.ChoicePaiment != null && commandModel.ChoicePaiment.Equals("Cash")) {
				context.paiement = new CashServiceImpl();
			}

			context.Pay();

			commandModel.State = new FinishedState();
			commandModel.Execute(); // command finished

			// TODO :  replace commandModel in list of commands			

			return commandMapper.ToDTO(commandModel);
		}
    }
}
