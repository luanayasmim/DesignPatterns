using CursoDesignPatterns.Aula6;


NotaFiscalBuilder criador = new NotaFiscalBuilder();
criador
    .ParaEmpresa("Caelum Ensino e Inovação")
    .ComCnpj("23.456.789/0001-12")
    .ComItem(new ItemDaNota("item1", 50))
    .ComItem(new ItemDaNota("item2", 100))
    .NaDataAtual()
    .ComObservacoes("Uma observação escrita aqui totalmente bem construída")
    .Constroi();

NotaFiscal nf = criador.Constroi();

Console.WriteLine(nf.ValorBruto);
Console.WriteLine(nf.Impostos);

Console.ReadKey();


/*
 Sem o builder
IList<ItemDaNota> itens = new List<ItemDaNota>();

double valorTotal = 0;
foreach (ItemDaNota itemDaNota in itens)
    valorTotal += itemDaNota.Valor;
double impostos = valorTotal * 0.05;

NotaFiscal nf = new NotaFiscal("razao", "cnpj", DateTime.Now, valorTotal, impostos, itens, "observação qualquer");
*/