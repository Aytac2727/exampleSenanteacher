using examples;
using System.Security.Cryptography;
using System.Text;

Product product = new()
{
    name = "samsung note 10",
    price = 980,
    description = "Galaxy Note 10+ modeli sözügedən smartfon seriyasının ən böyük ölçülü smartfonu olub. " +
    "Belə ki, smartfonun 3040x1440 piksel keyfiyyətli 6.75 düym Dynamic AMOLED ekranı ön panelin 94.2%-ni əhatə edir. "
};

Console.WriteLine("Mehsul haqqinda: " + product.GetDescriptionAsSeo());
Console.WriteLine("Mehsulun edv qiymeti: " + product.CalculateEDV());




