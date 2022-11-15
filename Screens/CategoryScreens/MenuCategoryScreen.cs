using System;

namespace BlogDapper.Screens.CategoryScreens
{
    public static class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de categorias");
            Console.WriteLine("----------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1- Listar categorias");
            Console.WriteLine("2- Cadastrar categoria");
            Console.WriteLine("3- Atualizar categoria");
            Console.WriteLine("4- Excluir categoria");
            Console.WriteLine("");
            Console.WriteLine("");
            var option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1: 
                    ListCategoryScreen.Load(1);
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3: 
                    UpdateCategoryScreen.Load();
                    break;
                case 4: 
                    DeleteCategoryScreen.Load();
                    break;
            }
        }
    }
}