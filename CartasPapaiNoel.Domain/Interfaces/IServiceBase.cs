﻿using CartasPapaiNoel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasPapaiNoel.Domain.Interfaces
{
	public interface IServiceBase<TEntity> where TEntity : IEntityBase
	{
		
		public TEntity GetEntity(int id);
		public IList<TEntity> GetAll();
		public bool Add(TEntity entity);
		public bool Save(IList<TEntity> entities);
		public bool Delete(int id);
		public bool Update(int id, TEntity entity);
	}
}
