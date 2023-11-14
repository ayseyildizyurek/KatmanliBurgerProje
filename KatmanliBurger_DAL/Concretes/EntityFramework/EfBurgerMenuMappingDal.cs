﻿using KatmanliBurger_DAL.Abstracts;
using KatmanliBurger_DAL.Contexts;
using KatmanliBurger_DATA.Concretes;

namespace KatmanliBurger_DAL.Concretes.EntityFramework
{
    public class EfBurgerMenuMappingDal : EfBaseDal<BurgerMenuMapping, BurgerDbContext>, IBurgerMenuMappingDal
    {
    }
}
