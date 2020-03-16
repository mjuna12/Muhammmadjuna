using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class Computer
    {
        private Monitor monitor;
        private Printer printer;
        private Processor processor;
        private RAM ram;
        private VGA vga;

        private Computer(Builder builder)
        {
            this.monitor = builder.monitor;
            this.processor = builder.processor;
            this.ram = builder.ram;
            this.vga = builder.vga;
        }

        internal Printer Printer { get => printer; set => printer = value; }

        public override string ToString()
        {
            return $"Monitor spec :{this.monitor}\n" +
                 $"Processor spec : {this.processor}\n" +
                 $"printer spec : {this.printer}\n" +
                 $"VGA spec : {this.vga}\n" +
                 $"RAM spec : {this.ram}";
        }
        public class Builder
        {
            public Monitor monitor;
            public Printer printer;
            public Processor processor;
            public RAM ram;
            public VGA vga;

            public Builder(RAM ram, VGA vga, Processor processor)
            {
                this.ram = ram;
                this.vga = vga;
                this.processor = processor;
            }

            public Builder withMonitor(Monitor monitor)
            {
                this.monitor = monitor;
                return this;
            }

            public Builder withPrinter(Printer printer)
            {
                this.printer = printer;
                return this;
            }
            public Computer build()
            {
                return new Computer(this);
            }
        }
    }
}