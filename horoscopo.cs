//Código feito por Paulo Archanjo (Hogtear)

using System;
class horoscopo {
  static void Main() {
    Console.WriteLine("\t\t<<[-----------]>>");
    Console.WriteLine("\t       <<<| HORÓSCOPO |>>>");
    Console.WriteLine("\t\t<<[-----------]>>");
    Console.Write("\nInforme seu nome: ");
    string nome = Console.ReadLine();
    Console.Write("Informe sua data de nascimento no formato DDMMAAAA,com barras: ");
    string dat_nasc = Console.ReadLine();
    int dia = Convert.ToInt32(dat_nasc.Substring(0,2));
    int mes = Convert.ToInt32(dat_nasc.Substring(3,2));
    Console.WriteLine("\nVocê nasceu no dia: " +dia);
    Console.WriteLine("Você nasceu no mês: " +mes);
    if (mes==03 && dia >=21 && dia >0 || dia<=19 && mes==04)
    {
    Console.WriteLine("\nO Seu signo é Áries ");
    Console.WriteLine("\nImpulsivo, o ariano não pensa muito sobre seus atos. Agitado, precisa de muita atividade para gastar a energia, senão pode ficar agressivo e explosivo.");
    }
        
    else if (mes==04 && dia >=20 && dia >0 || dia<=20 && mes==05)
    {
    Console.WriteLine("\nO Seu signo é Touro ");
    Console.WriteLine("\nTeimoso, o taurino é determinado e protetor. Precisa de segurança e estabilidade para ser feliz, e conquista isso com muito trabalho e concentração.");
    }
        
    else if (mes==05 && dia >=21 && dia >0 || dia<=21 && mes==06)
    {
    Console.WriteLine("\nO Seu signo é Gêmeos ");
    Console.WriteLine("\nEspontâneo e um pouco instável, o geminiano é uma verdadeira caixinha de surpresas. Como é volátil, muitas vezes nem mesmo o geminiano se entende, mas o importante é que ele está sempre de bom humor e em busca de aventuras.");
    }
        
    else if (mes==06 && dia >=22 && dia >0 || dia<=22 && mes==07)
    {
    Console.WriteLine("\nO Seu signo é Câncer ");
    Console.WriteLine("\nFamília é a palavra-chave para o canceriano. Tranquilo e emotivo, gosta de ficar em casa, fazer programas com quem ama e curtir momentos com os parentes. Curioso, faz amizade com facilidade, mas pode ser um pouco sensível.");
    }
        
    else if (mes==07 && dia >=22 && dia >0 || dia<=22 && mes==08)
    {
    Console.WriteLine("\nO Seu signo é Leão ");
    Console.WriteLine("\nEste é signo que veio para brilhar. O leonino gosta de chamar a atenção e ser o centro do mundo, mas também é muito amável e leal. Simpático e comunicativo, o nativo de leão pode ser um pouco ciumento e inseguro.");
    }
        
    else if (mes==08 && dia >=23 && dia >0 || dia<=22 && mes==09)
    {
    Console.WriteLine("\nO Seu signo é Virgem ");
    Console.WriteLine("\nPerspicaz e inteligente, o virginiano está acostumado com o sucesso, por isso se cobra muito, assim como aos demais. Por isso, pode ser um pouco rígido e magoar quem ama. Tímido, prefere programas tranquilos a grandes eventos.");
    }
        
    else if (mes==09 && dia >=23 && dia >0 || dia<=22 && mes==10)
    {
    Console.WriteLine("\nO Seu signo é Libra ");
    Console.WriteLine("\nO libriano gosta do que é belo e harmonioso. Não gosta de conflitos e por isso tenta ser imparcial em debates e brigas. Indeciso, pode demorar muito para escolher coisas simples, como o que comer ou vestir. Bom gosto define este signo.");
    }
        
    else if (mes==10 && dia >=23 && dia >0 || dia<=21 && mes==11)
    {
    Console.WriteLine("\nO Seu signo é Escorpião ");
    Console.WriteLine("\nDeterminado, o escorpiano vai até o fim para conquistar os seus objetivos. Sensual e romântico, gosta de estar em relacionamentos, mas pode ser desconfiado enquanto não se sentir seguro com a pessoa.");
    }
        
    else if (mes==11 && dia >=22 && dia >0 || dia<=21 && mes==12)
    {
    Console.WriteLine("\nO Seu signo é Sagitário ");
    Console.WriteLine("\nUm signo de bem com a vida, que está sempre em busca de ação e que vive rodeado de amigos. Este é o signo de sagitário, que é sonhador e adora conhecer pessoas e lugares novos.");
    }
        
    else if (mes==12 && dia >=22 && dia >0 || dia<=19 && mes==01)
    {
    Console.WriteLine("\nO Seu signo é Capricórnio ");
    Console.WriteLine("\nTrabalhador, tímido e educado, o capricórnio pode passar uma imagem de fechado e até mesmo antipático, mas é que ele eprecisa confiar em quem está ao seu lado para se abrir totalmente. Com paciência, ele se mostra um amigo leal e um companheiro fiel.");
    }
        
    else if (mes==01 && dia >=20 && dia >0 || dia<=18 && mes==02)
    {
    Console.WriteLine("\nO Seu signo é Aquário ");
    Console.WriteLine("\nIndependente, o aquariano preza muito por sua liberdade. Gosta de viajar, sair e conhecer pessoas novas. Tem uma mente aberta e gosta de tudo o que é inovador e moderno, desde roupas e tecnologia, até mesmo atitudes comportamentais.");
    }
        
    else if (mes==02 && dia >=19 && dia >0 || dia<=20 && mes==03)
    {
    Console.WriteLine("\nO Seu signo é Peixes ");
    Console.WriteLine("\nEste é o signo mais romântico do zodíaco. Sonhador e carinhoso, ele está sempre preocupado com o bem estar dos outros. Sensível e carinhoso, acredita em contos de fadas e acha que todos merecem um final feliz.");
    }
    else
    {
    Console.WriteLine("Opa, Acho que esta data está inválida...");
    }
    
  }
}

//Código feito por Paulo Archanjo (Hogtear)
