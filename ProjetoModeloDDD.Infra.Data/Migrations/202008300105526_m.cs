namespace Totvs.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponivel = c.Boolean(nullable: false),
                        PacienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnderecoId)
                .ForeignKey("dbo.Paciente", t => t.PacienteId)
                .Index(t => t.PacienteId);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        PacienteId = c.Int(nullable: false, identity: true),
                        CPF = c.String(nullable: false, maxLength: 100, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 150, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeMae = c.String(nullable: false, maxLength: 100, unicode: false),
                        Naturalidade = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PacienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Endereco", "PacienteId", "dbo.Paciente");
            DropIndex("dbo.Endereco", new[] { "PacienteId" });
            DropTable("dbo.Paciente");
            DropTable("dbo.Endereco");
        }
    }
}
