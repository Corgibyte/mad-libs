using Microsoft.AspNetCore.Http;
using System;

namespace MadLibs.Models
{
  public class MadLibData
  {
    private IFormCollection _words;

    public MadLibData(IFormCollection madlibWords)
    {
      _words = madlibWords;
    }

    public string GetWord(string name)
    {
      return _words[name];
    }
  }
}