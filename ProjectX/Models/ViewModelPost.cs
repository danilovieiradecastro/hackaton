﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectX.Models
{
  public class ViewModelPost
  {
    public IEnumerable<LocalSet> ListaBaladas { get; set; }
    public PostSet post { get; set;}
    public LocalSet BaladaSelecionada;
  }
}