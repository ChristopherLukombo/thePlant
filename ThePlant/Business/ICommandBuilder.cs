using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.Business
{
	// TODO : a voir si on garde
    public interface ICommandBuilder
    {
        CommandModel SetId(int id);
        CommandModel SetCreatedAt(DateTime date);

        CommandModel AddPlant(List<PlantModel> plants);
        CommandModel AddOption(List<IProduct> options);
    }
}
