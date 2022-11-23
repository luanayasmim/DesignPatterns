using CursoDesignPatterns.Aula7;

NotaFiscalBuilder criador = new NotaFiscalBuilder();
criador
    .ParaEmpresa("Caelum Ensino e Inovação")
    .ComCnpj("23.456.789/0001-12")
    .ComItem(new ItemDaNota("item1", 50))
    .ComItem(new ItemDaNota("item2", 100))
    .NaDataAtual()
    .ComObservacoes("Uma observação escrita aqui totalmente bem construída");
//.Constroi();

criador.AdicionaAcao(new EnviadorDeEmail());
criador.AdicionaAcao(new EnviadorDeSms());
criador.AdicionaAcao(new NotaFiscalDao());
criador.AdicionaAcao(new Multiplicador(0.05));

NotaFiscal nf = criador.Constroi();

Console.WriteLine(nf.ValorBruto);
Console.WriteLine(nf.Impostos);

Console.ReadKey();