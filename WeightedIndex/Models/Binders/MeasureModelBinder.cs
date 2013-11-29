using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeightedIndex.Models.Binders
{
    public class MeasureModelBinder : DefaultModelBinder
    {
        /// <summary>
        /// Generates a new GUID for each new measure added
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="bindingContext"></param>
        /// <param name="modelType"></param>
        /// <returns></returns>
        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
        {
            var measureModel = (MeasureModel)base.CreateModel(controllerContext, bindingContext, modelType);
            measureModel.id = Guid.NewGuid();
            return measureModel;
        }
    }
}