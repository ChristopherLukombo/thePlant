using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.Business.impl
{
    public class CommandServiceImpl : ICommandService
    {
        private List<PlantModel> plants = new List<PlantModel>();
        private List<IProduct> options = new List<IProduct>();

        public void AddOption(CommandModel command, IProduct product)
        {
            
            options.Add(product);
            command.Options = options;
        }

        public void AddPlant(CommandModel command, PlantModel plant)
        {
            plants.Add(plant);
        }

        private void Build()
        {
            ICommandBuilder command = new Builder();

            command.SetId(1);
            command.SetCreatedAt(new DateTime());

            command.AddPlant(plants);
            command.AddOption(options);
        }

        public void Pay()
        {
            CommandModel commandModel = new CommandModel();
            IStateCommand pending = new PendingState();


            commandModel.State = pending;
            // TODO : IMPLEMENTER UN PAIEMENT AVEC PAYPAL
        }
    }
}
