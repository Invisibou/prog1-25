namespace Aula01.Models
{
    public class Variaveis
    {
        //Tipos implícitos
        //var teste = 10;

        //Anotação de Tipos
        public int userCount = 10;

        //Uma variável pode ser declarada e não inicializada
        public int totalCount;


        //CONSTANTES
        //PARA DECLARAR UMA CONSTANTE UTILIZAMOS A PALAVRA-CHAVE CONST
        //No entanto, a cCONST deve ser inicilizada quando declarada

        public const int interestRate = 10;
        //O método construtor é invocado na instanciação do objeto por meio da palavra reservada new.
        //Por regra, o construtor sempre tem o mesmo nome da classe

        public byte minByte = 0;
        public byte maxByte = 255;

        public sbyte minSbyte = -128;
        public sbyte maxSbyte = 127;

        public short minShort = -32768;
        public short maxShort = 32767;

        public ushort minUshort = 0;
        public ushort maxUshort = 65535;

        public int minInt = -2147483648;
        public int maxInt = 2147483647;

        public uint minUint = 0;
        public uint maxUint = 4294967295;

        public long minLong = -9223372036854775808;
        public long maxLong = 9223372036854775807;


        // Parentêses é um procedimento
        // Colchetes é matriz
        // ; fim da sentença.
        public Variaveis()
        {
            totalCount = 0;

            //Tipo Implícito, você não informou se é tipo inteiro ou qualquer outro tipo, portanto, é implicito
            //A palavra chave var se encarrega de definir o tipo da variável na instrução de atribuição
            var signalStrength = 22;             
            var companyName = "ACME";
        }

    }
}
