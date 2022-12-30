using System;
using System.Collections.Generic;
using System.Text;
using ECommerceBackend.Business.Constants;
using Castle.DynamicProxy;
using ECommerceBackend.Core.Utilities.Interceptors;
using ECommerceBackend.Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceBackend.Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
    }
}
