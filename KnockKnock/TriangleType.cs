namespace knockknock.readify.net
{
    using System.Runtime.Serialization;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }
}