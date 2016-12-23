/* 
 *This code is property of Vasily Tserekh
 *if you like it you can visit my personal dev blog
 *http://vasilydev.blogspot.com
*/

using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;
using ShadowEngine;

namespace SistemaSolar
{
    class Planet
    {
        Planets tipo;
        Position p;
        float anguloRotacion;
        float anguloOrbita;
        float radio;
        int list;
        static Random r = new Random();
        float velocidadOrbita;
        string texture;
        Satellite moon;
        Satellite s2;
        Satellite s1;
        Satellite s3;


        public Planet(float radio, Planets tipo, Position posision, string texture,bool hasMoon)
        {
            this.radio = radio;
            this.tipo = tipo;
            p = posision;
            anguloOrbita = r.Next(360);
            velocidadOrbita = (float)r.NextDouble() * 0.3f;
            this.texture = texture;
            if (hasMoon)
            {
               // moon = new Satellite(0.1f, Planets.Earth, p, "luna.jpg",);
                s2 = new Satellite(0.05f, Planets.Earth, p, "red.jpg", @"C:\Users\maoreliy\SistemaSolar\SistemaSolar\Alpha.txt");
                s1 = new Satellite(0.05f, Planets.Earth, p, "green.jpg", @"C:\Users\maoreliy\SistemaSolar\SistemaSolar\Beta.txt");
                s3 = new Satellite(0.05f, Planets.Earth, p, "yellow.jpg", @"C:\Users\maoreliy\SistemaSolar\SistemaSolar\Gamma.txt");
            }   
        }

        public void Create()
        {
            Glu.GLUquadric quadratic = Glu.gluNewQuadric(); //crear el objeto cuadric
            Glu.gluQuadricNormals(quadratic, Glu.GLU_SMOOTH);
            Glu.gluQuadricTexture(quadratic, Gl.GL_TRUE);

            list = Gl.glGenLists(1); // crear la lista
            Gl.glNewList(list, Gl.GL_COMPILE);
            Gl.glPushMatrix();
            Gl.glRotated(270, 1, 0, 0);
            Glu.gluSphere(quadratic, radio, 32, 32); //creo la esfera 
            Gl.glPopMatrix();
            Gl.glEndList();
            if (tipo == Planets.Earth)
            {
                //moon.Create();
                s1.Create();
                s2.Create();
                s3.Create();
            }
        }

        public void DrawOrbit()
        {
            Gl.glBegin(Gl.GL_LINE_STRIP);

            for (int i = 0; i < 361; i++)
            {
                Gl.glVertex3f(p.x * (float)Math.Sin(i * Math.PI / 180), 0, p.x * (float)Math.Cos(i * Math.PI / 180));
            }

            //Gl.glVertex3f(0, 0, 5);
            
            Gl.glEnd(); 
        }

        public void Paint()
        {
            if (MainForm.ShowOrbit)
            {
                DrawOrbit();
            }
            if (tipo == Planets.Earth)
            {
                //moon.Paint(p, anguloOrbita);
                s1.Paint(p, anguloOrbita);
                s2.Paint(p, anguloOrbita);
                s3.Paint(p, anguloOrbita);
            }
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName(texture));
            Gl.glPushMatrix();
            anguloOrbita += velocidadOrbita;
            anguloRotacion += 0.6f;              //earth speed rotation
            //Gl.glRotatef(anguloOrbita, 0, 1, 0); //rotate Relative to the sun
            //p.y = p.y + 0.01f;
            //p.x = p.x + 0.01f;
            //p.z = p.z + 0.1f;
            Gl.glTranslatef(-p.x, -p.y, -p.z);
            //Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex3f(0f, 0f, 0f); // origin of the line
            Gl.glVertex3f(p.x, p.y, p.z); // ending point of the line
            Gl.glEnd();
            Gl.glRotatef(anguloRotacion, 0, 1, 0); //rotating relative himself

           
            Gl.glCallList(list);
          
            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
        } 
    }
}
