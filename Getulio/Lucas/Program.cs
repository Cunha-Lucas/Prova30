using Lucas.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDataContext>();

var app = builder.Build();

app.MapGet("/", () => "API de Folha de Pagamento");

app.MapPost("/api/funcionario", async (Funcionario funcionario, AppDataContext context) =>
{
    context.Add(funcionario);
    await context.SaveChangesAsync();
    return Results.Created($"/funcionario/{funcionario.Id}", funcionario);
});

//POST: /funcionario/cadastrar
app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionario,
    [FromServices] AppDataContext ctx) =>
{
    ctx.Funcionarios.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);
});

// //GET: /api/funcionario/buscar/{id}
// app.MapGet("/api/funcionario/buscar/{id}", ([FromRoute] string id,
//     [FromServices] AppDataContext ctx) =>
// {
//     Funcionario? funcionario = ctx.Funcionarios.Find(id);

//     if (funcionario == null)
//     {
//         return Results.NotFound();
//     }
//     return Results.Ok(funcionario);
// });

// //POST: /api/funcionario/cadastrar
// app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionario,
//     [FromServices] AppDataContext ctx) =>
// {
//     ctx.Funcionarios.Add(funcionario);
//     ctx.SaveChanges();
//     return Results.Created("", funcionario);
// });

// //DELETE: /api/funcionario/deletar/{id}
// app.MapDelete("/api/funcionario/deletar/{id}", ([FromRoute] string id,
//     [FromServices] AppDataContext ctx) =>
// {
//     Funcionario? funcionario = ctx.Funcionarios.Find(id);
//     if (funcionario == null)
//     {
//         return Results.NotFound();
//     }
//     ctx.Funcionarios.Remove(funcionario);
//     ctx.SaveChanges();
//     return Results.Ok(funcionario);
// });

// //PUT: /api/funcionario/alterar/{id}
// app.MapPut("/api/funcionario/alterar/{id}", ([FromRoute] string id,
//     [FromBody] Funcionario funcionarioAlterado, [FromServices] AppDataContext ctx) =>
// {
//     Funcionario? funcionario = ctx.Funcionarios.Find(id);
//     if (produto == null)
//     {
//         return Results.NotFound();
//     }
//     funcionario.Nome = funcionarioAlterado.Nome;
//     funcionario.Quantidade = funcionarioAlterado.Quantidade;
//     funcionario.Valor = funcionarioAlterado.Valor;
//     ctx.Funcionarios.Update(funcionario);
//     ctx.SaveChanges();
//     return Results.Ok(funcionario);
// });


app.Run();