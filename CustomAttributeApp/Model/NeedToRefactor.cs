using System;

namespace CustomAttributeApp.Model
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false)]
    public sealed class NeedToRefactor : Attribute
    {

    }
}
