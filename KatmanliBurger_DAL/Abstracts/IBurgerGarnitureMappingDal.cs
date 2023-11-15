﻿using KatmanliBurger_DATA.Concretes;

namespace KatmanliBurger_DAL.Abstracts
{
    public interface IBurgerGarnitureMappingDal:IBaseDal<BurgerGarnitureMapping>
    {
        void Create(IEnumerable<BurgerGarnitureMapping> entities);
        void Update(IEnumerable<BurgerGarnitureMapping> entities);

        IEnumerable<BurgerGarnitureMapping> GetByBurgerId(int id);
        //void Delete(BurgerGarnitureMapping entity);
        void Delete(IEnumerable<BurgerGarnitureMapping> entities);
    }
}
