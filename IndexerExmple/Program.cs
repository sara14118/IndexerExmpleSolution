namespace IndexerExmple

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = new IP(119, 112, 45, 67);

            var firstSegment = ip[0];

            Console.WriteLine(ip.Address);






        }
    }



    public class IP
    {
        private int[] segments = new int[4];



        public int this[int index]
        {
            get
            {

                return segments[index];

            }
            set
            {
                segments[index] = value;

            }
        }

        //segment 1-255
        public IP(int segment1, int segment2, int segment3, int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;


        }
        public string Address => string.Join(".", segments);

    }
}