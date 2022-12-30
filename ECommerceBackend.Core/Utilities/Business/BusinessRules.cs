﻿using ECommerceBackend.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] results)
        {
            foreach(var result in results)
            {
                if (!result.Success)
                {
                    return result;
                }
            }
            return null;
        }
    }
}
