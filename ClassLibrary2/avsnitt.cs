﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    public class avsnitt
    {

        //Poster som tillsammans bildar ett avsnitt
        private oppningsPost oppning;
        private string betalningar;
        private string avdrag;
        private string fakturor;
        private slutsummaPost slutpost;
        

        //hjälp-variablar
        private int sum;


        public avsnitt(string bgNummer, string valuta) 
        {
            this.oppning = new oppningsPost(valuta, bgNummer);
        }
        public void addPayment(string bgNumber, string OCR, string belopp, string paydate, string info) 
        {
            var betalning = new BetalningsPost(bgNumber, OCR, belopp, paydate, info);
                betalningar = betalningar +  betalning.Post + Environment.NewLine;
                sum += Int32.Parse(belopp);
        }
        public void addKreditFaktura(string bevakning, string bgNumber, string OCR, string belopp, string paydate, string info)
        {
            var faktura = new kreditfakturaPost(bevakning, bgNumber, OCR, belopp, paydate, info);
            fakturor = fakturor + faktura.Post + Environment.NewLine;
        }
        public void addAvdrag(string bgNumber, string OCR, string belopp, string paydate, string info) 
        {
            var dragav = new avdragsPost(bgNumber, OCR, belopp, paydate, info);
            avdrag += Environment.NewLine + dragav;
            sum += Int32.Parse(belopp);
        }



        public string format() 
        {
            var Bg = this.oppning.BGNumber;
            var numPay = this.betalningar.Count().ToString();
            var summa = sum.ToString();
            slutpost = new slutsummaPost(Bg, numPay, summa);
            var result = oppning.post + betalningar + fakturor + avdrag + slutpost.Post;
            return result;
        }

    }
}
