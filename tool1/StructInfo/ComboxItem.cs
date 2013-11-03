using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MillionTools.tool1.StructInfo
{
    public class ComboxItem
    {
            private string _text;
            private object _value;

            public override string ToString()
            {
                return this._text;
            }

            public string Text
            {
                get
                {
                    return this._text;
                }
                set
                {
                    this._text = value;
                }
            }

            public object Value
            {
                get
                {
                    return this._value;
                }
                set
                {
                    this._value = value;
                }
            }
        }
    }

