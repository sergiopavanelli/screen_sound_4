
# Screen Sound 4

Projeto desenvolvido para fins educacionais na plataforma [Alura](https://www.alura.com.br/), com foco em práticas de C# e .NET. O sistema realiza o consumo de uma API pública de músicas, aplica filtros e ordenações utilizando LINQ, e exibe resultados no console.

## Funcionalidades Técnicas

- **Consumo de API**: Utiliza `HttpClient` para obter dados de músicas em formato JSON a partir de uma fonte externa.
- **Serialização/Deserialização**: Emprega `System.Text.Json` para converter os dados JSON em objetos C#.
- **Modelagem de Dados**: A classe `Musica` representa cada música, com propriedades anotadas para mapeamento JSON.
- **Filtros e Ordenações LINQ**:
   - `LinqFilter.FiltrarTodosOsGenerosMusicais`: Lista todos os gêneros distintos presentes na base.
   - `LinqFilter.FiltrarArtistasPorGeneroMusical`: Exibe artistas filtrados por gênero musical.
   - `LinqOrder.ExibirListaDeArtistasOrdenados`: Mostra artistas em ordem alfabética, sem repetições.
- **Exibição de Dados**: Resultados são apresentados no console, com métodos específicos para detalhamento de músicas.

## Estrutura do Projeto

- `Program.cs`: Ponto de entrada. Responsável por consumir a API, deserializar os dados e acionar os filtros/ordenações.
- `Modelos/Musica.cs`: Define o modelo de dados da música, com propriedades e método de exibição.
- `Filtros/LinqFilter.cs`: Métodos estáticos para filtragem de gêneros e artistas via LINQ.
- `Filtros/LinqOrder.cs`: Métodos estáticos para ordenação de artistas via LINQ.
- `screen_sound_4.csproj` / `.sln`: Arquivos de configuração do projeto .NET.

## Como Executar

1. Certifique-se de ter o [.NET 9.0 SDK](https://dotnet.microsoft.com/download) instalado.
2. Clone este repositório ou faça o download dos arquivos.
3. No terminal, navegue até a pasta do projeto e execute:

    ```bash
    dotnet run
    ```

## Objetivo

Este projeto é destinado exclusivamente ao aprendizado de C# e .NET, sem fins comerciais.

---
Desenvolvido por Sérgio Pavanelli, durante os estudos na Plataforma Alura.

© 2025 Sérgio Pavanelli. Todos os direitos reservados.