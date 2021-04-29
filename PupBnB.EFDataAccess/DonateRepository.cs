using BankingSystem.EFDataAccess;
using Microsoft.EntityFrameworkCore;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PupBnB.EFDataAccess 
{
    public class DonateRepository : BaseRepository<DonateModel>, IDonateRepository
    {
        public DonateRepository(PupBnBDbContext dbContext) : base(dbContext)
        {
            
        }

        
    }
}
