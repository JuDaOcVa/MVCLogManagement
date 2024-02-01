using System;
using System.Collections.Generic;

namespace Prj_JDOV_LogMngmtSerilogMoviesWebApp.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? MovName { get; set; }

    public string? MovDirector { get; set; }

    public string? MovType { get; set; }

    public int? MovYear { get; set; }

    public decimal? MovWorldWideGross { get; set; }

    public DateTime? MovDateCreated { get; set; }
}
