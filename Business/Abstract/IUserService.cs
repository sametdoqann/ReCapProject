﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);

        void Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
