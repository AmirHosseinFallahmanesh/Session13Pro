using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session13Pro.Infrastructure
{
    public class MyViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            foreach (var item in viewLocations)
            {
                yield return item;
            }
         
            yield return "/AdminViews/{1}/{0}cshtml";
            yield return "/sharedFolder/{0}.cshtml";
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            context.Values["Time"] = DateTime.Now.ToString();
        }
    }
}
