var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*Creare una web api con un controller che permetta ad un client di popolare una lista di oggetti 

Prelevare tutti gli elementi della lista .

Prelevare un determinato elemento della lista .

Prelevare solamente determinati elementi della lista .

Eliminare un elemento della lista .

*E se come ritorno volessi avere uno status code personalizzato? Quali sono le convenzioni per i verbi Get/Post/Delete
*/