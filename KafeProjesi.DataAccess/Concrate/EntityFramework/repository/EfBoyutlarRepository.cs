﻿using Core.DataAccess.Concrate.EntityFramework;
using KafeProjesi.DataAccess.Abstract;
using KafeProjesi.DataAccess.Concrate.EntityFramework.context;
using KafeProjesi.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.DataAccess.Concrate.EntityFramework.repository
{
    public class EfBoyutlarRepository : EfRepositoryBase<Boyutlar, KafeVeriTabanıDbContext>, IBoyutlarRepository
    {
    }
}
