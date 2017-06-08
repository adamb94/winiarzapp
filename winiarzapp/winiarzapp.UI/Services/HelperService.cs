﻿using System;
using winiarzapp.UI.Windows.RecipeCreator;
using Winiarzapp.Core.Data;

namespace Winiarzapp.UI.Services
{
    public class HelperService
    {
        /// <summary>
        /// Załaduj i wyświetl plik pomocy (*.chm).
        /// </summary>
        public static void ShowHelp()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Otwórz okno "History" jako "dialog".
        /// </summary>
        public static void ShowHistory()
        {
            throw new NotImplementedException();
        }

        public static void ShowRecipeCreator(IRecipeSource recipeSource) //metoda wyświetlająca kreator przepisów
        {
            RecipeCreator rc = new RecipeCreator();
            rc.Initialize(recipeSource);
            rc.ShowDialog();
        }
    }
}
