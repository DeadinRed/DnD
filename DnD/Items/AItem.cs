using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DnD
{
    public abstract class AItem : DynamicObject
	{

        protected string className;

        public string ClassName {
            get {
                return this.className;
            }
            set {
                className = value;
            }
        }

        Dictionary<string, object> _dynamic = new Dictionary<string, object> ();
        public override bool TryGetMember (GetMemberBinder binder, out object result)
        {
            bool qq = false;
            result = null;
            if (_dynamic.ContainsKey (binder.Name)) {
                result = _dynamic [binder.Name];
                qq = true;
            } else {
                result = "Свойство не найдено!";
                qq = false;
            }
            return qq;
        }

        public override bool TrySetMember (SetMemberBinder binder, object value)
        {
            _dynamic [binder.Name] = value;
            return true;
        }

        // вызов метода
        public override bool TryInvokeMember (InvokeMemberBinder binder, object [] args, out object result)
        {
            dynamic method = _dynamic [binder.Name];
            result = method ((int)args [0]);
            return result != null;
        }



	}
}

