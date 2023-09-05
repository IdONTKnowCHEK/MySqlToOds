using System;
using System.Collections.Generic;

namespace MySqlToOds.Models;

public partial class StudentDatum
{
    public int StudentId { get; set; }

    public string? School { get; set; }

    public string? Sex { get; set; }

    public int? Age { get; set; }

    public string? Address { get; set; }

    public string? Famsize { get; set; }

    public string? Pstatus { get; set; }

    public int? Medu { get; set; }

    public int? Fedu { get; set; }

    public string? Mjob { get; set; }

    public string? Fjob { get; set; }

    public string? Reason { get; set; }

    public string? Guardian { get; set; }

    public int? Traveltime { get; set; }

    public int? Studytime { get; set; }

    public int? Failures { get; set; }

    public string? Schoolsup { get; set; }

    public string? Famsup { get; set; }

    public string? Paid { get; set; }

    public string? Activities { get; set; }

    public string? Nursery { get; set; }

    public string? Higher { get; set; }

    public string? Internet { get; set; }

    public string? Romantic { get; set; }

    public int? Famrel { get; set; }

    public int? Freetime { get; set; }

    public int? Goout { get; set; }

    public int? Dalc { get; set; }

    public int? Walc { get; set; }

    public int? Health { get; set; }

    public int? Absences { get; set; }

    public int? G1 { get; set; }

    public int? G2 { get; set; }

    public int? G3 { get; set; }
}
