using MeowLab;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});


//���������� ��������
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//����������� ��
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    // ������� ������ ����������� � ���� ������ MySQL
    string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    // ������������� ��������� ������ ��� MySQL
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

//��������� Cors
app.UseCors("AllowOrigin");


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();