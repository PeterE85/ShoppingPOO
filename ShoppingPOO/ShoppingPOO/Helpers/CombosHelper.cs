using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shooping.Helpers;
using ShoppingPOO.Data;

namespace ShoppingPOO.Helpers
{
	public class CombosHelper : ICombosHelper
	{
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }

		//Metodos ===================
        public async Task<IEnumerable<SelectListItem>> GetComboCategoriesAsync() //esto devuelve el combo de categorias
		{
            List<SelectListItem> list = await _context.Categories.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = $"{x.Id}"
            })
               .OrderBy(x => x.Text)
               .ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Text = "[Select one Category...]",
                Value = "0"
            });

            return list;
        }

        //====================================
        public async Task<IEnumerable<SelectListItem>> GetComboCitiesAsync(int stateId) 
        {
            List<SelectListItem> list = await _context.Cities
                .Where(x => x.State.Id == stateId)
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = $"{x.Id}"
                })
                .OrderBy(x => x.Text)
                .ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Text = "[Select one City...]",
                Value = "0"
            });

            return list;
        }

        //===============================================================================
        public async Task<IEnumerable<SelectListItem>> GetComboCountriesAsync()
        {
            List<SelectListItem> list = await _context.Countries.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = $"{x.Id}"
            })
                .OrderBy(x => x.Text)
                .ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Text = "[Select one Country...]",
                Value = "0"
            });

            return list;
        }


        //====================================================================================
        public async Task<IEnumerable<SelectListItem>> GetComboStatesAsync(int countryId)
        {
            List<SelectListItem> list = await _context.States
                .Where(x => x.Country.Id == countryId) //solo devolvera los estados pertenecientes a este pais
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = $"{x.Id}"
                })
                .OrderBy(x => x.Text)
                .ToListAsync();

            list.Insert(0, new SelectListItem
            {
                Text = "[Select one State...]",
                Value = "0"
            });

            return list;
        }


    }
}
