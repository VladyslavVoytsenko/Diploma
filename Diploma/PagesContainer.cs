using System;
using Diploma.Pages;

namespace Diploma
{
    public static class PagesContainer
    {
        public static readonly Settings Settings = new Settings();
        [Obsolete("Obsolete")] public static readonly Home Home = new Home();
    }
}