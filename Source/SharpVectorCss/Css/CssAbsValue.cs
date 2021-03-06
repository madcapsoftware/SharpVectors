using System;
using System.Xml;

namespace SharpVectors.Dom.Css
{           
	public class CssAbsValue : CssValue
	{
        private string     _propertyName;
        private CssValue   _cssValue;
        private XmlElement _element;
		
		public CssAbsValue(CssValue cssValue, string propertyName, XmlElement element) 
            : base()
		{
			_cssValue     = cssValue ?? throw new ArgumentNullException(nameof(cssValue));
			_propertyName = propertyName;
			_element      = element ?? throw new ArgumentNullException(nameof(element));
		}

		public override string CssText
		{
			get
			{
				return _cssValue.CssText;
			}
		}

		public override CssValueType CssValueType
		{
			get
			{
				return _cssValue.CssValueType;
			}
		}
	}
}
