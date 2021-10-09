using System;

namespace TakeHomeAssignment.Controllers
{
    internal class JSONObject
    {
        private object json;

        public JSONObject(object json)
        {
            this.json = json;
        }

        internal object getJSONArray(string v)
        {
            throw new NotImplementedException();
        }
    }
}