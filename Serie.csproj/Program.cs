using System;

namespace Series
    {
     class Program
        {
          static SerieRepositorio repositorio = new SerieRepositorio();
          static void Main(string[] args)
          {
              string opcaoUsuario = ObterOpcaoUsuario();
              while (opcaoUsuario.ToUpper() != "X")            
          {
          switch (opcaoUsuario)
          {
              case "1":
              ListaSerie();
              break;
              case "2":
              InserirSerie();
              break;
              case "3":
              AtualizaSerie();
              break;
              case "4":
              ExcluirSerie();
              break;
              case "5":
              VisualizarSerie();
              break;
              case "C":
              Console.Clear();
              break;
              default:
                 throw new ArgumentOutOfRangeException();  
            
                 } 
                 opcaoUsuario = obbetOpcaoUsuario();
          }
          Console.WriteLine("Obrigado por ultilizar nossos serviços.");
          Console.ReadLine();

          }
          private static void ExcluirSerie()
          {
              Console.Write("Digite o id da serie:");
              int indiceSerie = int.Parse(Console.ReadLine());
              repositorio.Excluir(indeceSerie);

          } 
          private static void VisualizarSerie() 
          {
              Console.write.Write("Digite o id da serie:");
              int indiceSerie = int.Parse(Console.ReadLine());

              var serie = repositorio.RetornaPorId(indiceSerie);
              Console.WriteLine(serie);

          } 
          private static void AtualizaSerie()
          {
              Console.WriteLine("Digite o id da serie:");
              int indeceSerie = int.Parse(Console.ReadLine());

              foreach (int i in enum.GetValues(typeof(Genero)))
              {
                 Console.WirteLie("{o}-{1}", i, Enum.GetName(typeof(Genero), i)); 
              }
              Console.Write("Digite o genero entre as opiçoes acima:");
              int entradaGenero = int.Parse(Console.ReadLine());

              Console.Write("Digita o titulo da serie:");
              string entradaTitulo = Console.ReadLine();

              Console.Write("Digite o Ano de Inicio da Serie:");
              int entradaAno = int.Parse(Console.ReadLine());

              Console.Write("dIGITE A Descrição da Serie:");
              string entradaDescrição = Console.ReadLine();


              Serie AtualizaSerie = new Serie(id: indiceSerie,
                                              genero: (Genero)entradaGenero,
                                              titulo: entradaTitulo,
                                              ano: entredaAno,
                                              descricao: entradaDescricao);

              Repositorio.Atualiza(indice, atualizaSerie);                                
          } 
          private static void ListaSerie()      
          {
              Console.WriteLine("Listar serie");
              var lista = repositorio.Lista();
              
              if (lista.Count == 0)
              {
                  Console.WriteLine("Nenhuma serie cadastrada.");
                  return;

              }
              foreach (var serie in lista)
              {
                  var excluido = serie.retornaExcluido();
                  console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(),(excluido ? "*Excluido*" : ""));

              }
          }
          
          private static void InsereSerie()
          {
              Console.WriteLine("Inserir nova serie");
              foreach (int i in Enum.GetValues(typeof(Genero)))
              {
                  Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
              }
              Console.Write("Digite o genero entre as opções a cima:");
              int entradaGenero = int.Parse(Console.ReadLine());

              Console.Write("Digite o Titulo da Serie:");
              string entradaTitulo = Console.ReadLine();

              Console.Write("Digite o Ano de inicio da Serie:");
              int entradaAno = int.Parse(Console.ReadLine());

              Console.Write("Digite a Descrição da Serie:");
              string entradaDescricao = Console.ReadLine();

              Serie nonaSerie = new Serie(id: repositorio.ProximoId(),
                                          genero: (Genero)entradaGenero,
                                          titulo: entadaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDescricao);

              repositorio.Insere(novaSerie);
          }

          private static string ObiterOpcaoUsuario()
          {
              Console.WriteLine();
              Console.WriteLine("Series a seu dispor!!!");
              Console.WirteLine("Informe a opção desejada:");

              Console.WriteLine("1- Listar series");
              console.WriteLine("2- Inserir nova serie");
              Console.WriteLine("3- Atualizar serie");
              Console.WriteLine("4- Excluir serie");
              Console.WriteLine("5- Visualizar serie");
              Console.WriteLine("C- Limpar tela");
              Console.WriteLine("X- sair");
              Console.WriteLine();

              string opcaoUsuario = Console.Readline().ToUpper();
              Console.WriteLine();
              return opcaoUsuario;
              

        
          } 
        }
    }