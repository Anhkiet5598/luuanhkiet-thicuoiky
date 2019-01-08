/*
 * Created by SharpDevelop.
 * User: Anh Kiet
 * Date: 1/8/2019
 * Time: 8:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;


namespace Orm._HTron
{
    class HinhHoc
    {
        public List<csPoin> save = new List<csPoin>();

        public HinhHoc()
        {

        }
     
        public void LoadData(Dictionary<string, List<csPoin>> input, string input_Name)
        {
            foreach (var item in input)
            {
                if (item.Key == input_Name)
                {
                    save = item.Value;
                }
            }
        }
        public List<csPoin> SaveData()
        {
            List<csPoin> temp = new List<csPoin>();
            temp = save;
            return temp;
        }
    }
    class Line : HinhHoc
    {
        public csPoin begin = new csPoin();
        public csPoin end = new csPoin();      
        public Line()
        {
            begin = new csPoin(0, 0);
            end = new csPoin(0, 0);
        }
        public Line(csPoin A, csPoin B)
        {
            begin = A;
            end = B;
        } 
       
        public  void Draw(Graphics g, Pen pen)
        {
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    g.DrawLine(pen, save[i].x, save[i].y, save[i + 1].x, save[i + 1].y);
                }
            }
        }
        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }
    class Ellipse : HinhHoc
    {
        public csPoin begin = new csPoin();
        public csPoin end = new csPoin();         
        public Ellipse()
        {
            begin = new csPoin(0, 0);
            end = new csPoin(0, 0);
        }
        public Ellipse(csPoin A, csPoin B)
        {
            begin = A;
            end = B;
        }
        public void Draw(Graphics g, Pen pen)
        {
            Rectangle rect = new Rectangle();
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    rect.X = save[i].x;
                    rect.Y = save[i].y;
                    rect.Size = new Size(save[i+1].x - save[i].x, save[i + 1].y - save[i].y);
                    g.DrawEllipse(pen, rect);
                }
            }
        }
        public void AddPoin()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
            
        }
//        public clsTamGiac( csPoin begin, csPoin end)
//        {
//        	diemdau = begin;
//        	diemcuoi = end;
//        }
    }
}