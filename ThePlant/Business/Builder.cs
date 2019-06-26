using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.Business
{
    public class Builder : ICommandBuilder
    {
        private CommandModel command = new CommandModel();

        public CommandModel AddOption(List<IProduct> options)
        {
            command.Options = options;
            return command;
        }

        public CommandModel AddPlant(List<PlantModel> plants)
        {
            command.Plants = plants;
            return command;
        }

        public CommandModel SetCreatedAt(DateTime date)
        {
            command.CreatedAt = date;
            return command;
        }

        public CommandModel SetId(int id)
        {
            command.Id = id;
            return command;
        }
    }
}
