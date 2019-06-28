using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.dao
{
	public class CommandDAOImpl : ICommandDAO
	{
		List<CommandModel> commandModels = new List<CommandModel>() { };

		public CommandDAOImpl()
		{
			this.Init();
		}

		public List<CommandModel> FindAll()
		{
			return commandModels;
		}

		private void Init()
		{
			CommandModel commandModel = new CommandModel()
			{
				Id = 1,
				CreatedAt = DateTime.Now,
				ChoicePaiment = "Paypal"
			};

			commandModels.Add(commandModel);
		}

		public CommandModel Save(CommandModel commandModel)
		{
			commandModels.Add(commandModel);
			return commandModel;
		}

		public CommandModel Update(CommandModel commandModel)
		{
            int index = commandModels.Select(x => x.Id).ToList().IndexOf(commandModel.Id);

            if (index == -1)
                return null;

            commandModels.RemoveAt(index);
            commandModels.Insert(index, commandModel);

			return commandModel;
		}
	}
}
