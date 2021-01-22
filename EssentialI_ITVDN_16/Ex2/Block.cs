using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_16.Ex2
{
    class Block
    {
        int A { get; }
        int B { get; }
        int C { get; }
        int D { get; }

        public Block(int A, int B, int C, int D)
        {
            this.A = A;

            this.B = A;

            this.C = A;

            this.D = A;

        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Block block = (Block)obj;
            return (A == block.A) && (B == block.B) && (C == block.C) && (D == block.D);

        }
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
