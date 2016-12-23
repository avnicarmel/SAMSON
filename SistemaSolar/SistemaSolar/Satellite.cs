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
    class Satellite
    {
        Planets tipo;
        Position planetaPos;
        Position lunaPos;
        float anguloRotacion;
        float angulOrbitaPlaneta;
        float radio;
        int list;
        float velocidadOrbita;
        string texture;
        Position pS;
        Position pSN;
        Position pSP;
        int i = 0;
        float ratio = 1 / 6371f;
        string[] lines;
        private string _filePath;

        public Satellite(float radio, Planets tipo, Position posicion, string texture, string filePath)
        {
            this.radio = radio;
            this.tipo = tipo;
            planetaPos = posicion;
            lunaPos = planetaPos;
            lunaPos.x += 3; 
            //velocidadOrbita = (float)r.NextDouble() * 0.3f;
            this.texture = texture;
            pS = posicion;
            _filePath = filePath;
            lines = System.IO.File.ReadAllLines(@_filePath);



        }

        public void Create()
        {
            Glu.GLUquadric quadratic = Glu.gluNewQuadric();
            Glu.gluQuadricNormals(quadratic, Glu.GLU_SMOOTH);
            Glu.gluQuadricTexture(quadratic, Gl.GL_TRUE);

            list = Gl.glGenLists(1);
            Gl.glNewList(list, Gl.GL_COMPILE);
            Gl.glPushMatrix();
            Gl.glRotated(270, 1, 0, 0);
            Glu.gluSphere(quadratic, radio, 32, 32);
            Gl.glPopMatrix();
            Gl.glEndList();
        }

        public void Paint(Position p,float anguloOrbita)
        {
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName(texture));
            
            anguloOrbita += velocidadOrbita;
            anguloRotacion += 0.6f;
            angulOrbitaPlaneta += 0.6f;
            Gl.glPushMatrix();
            //Gl.glRotatef(anguloOrbita, 0, 1, 0); //orbit rotation
            //pS.x += 0.1f;
            try
            {
                i++;
                System.Console.WriteLine(float.Parse((lines[i].Split('\t'))[0]));
                pS.x = p.x + float.Parse((lines[i ].Split('\t'))[0]) * ratio;
                pS.y = p.y + float.Parse((lines[i ].Split('\t'))[1]) * ratio;
                pS.z = p.z + float.Parse((lines[i ].Split('\t'))[2]) * ratio;


            }
            catch(Exception e)
            {
                //todo: check if it's the end of file exception
                i = 0;

            }
            for(int j=0;j<i;j++) {
                pSP.x = p.x + float.Parse((lines[j].Split('\t'))[0]) * ratio;
                pSP.y = p.y + float.Parse((lines[j].Split('\t'))[1]) * ratio;
                pSP.z = p.z + float.Parse((lines[j].Split('\t'))[2]) * ratio;
                pSN.x = p.x + float.Parse((lines[j+1].Split('\t'))[0]) * ratio;
                pSN.y = p.y + float.Parse((lines[j+1].Split('\t'))[1]) * ratio;
                pSN.z = p.z + float.Parse((lines[j+1].Split('\t'))[2]) * ratio;
                Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex3f(-pSP.x, -pSP.y, -pSP.z); // origin of the line
                Gl.glVertex3f(-pSN.x, -pSN.y, -pSN.z); // ending point of the line
                Gl.glEnd();

            }

            Gl.glTranslatef(-pS.x, -pS.y, -pS.z);
            //Gl.glRotatef(angulOrbitaPlaneta, 0, 1, 0); // earth rotation
            //Gl.glTranslatef(2, 0, 0);
            /* Gl.glBegin(Gl.GL_LINES);
             Gl.glVertex3f(0f, 0f, 0f); // origin of the line
             Gl.glVertex3f(-p.x , -p.y,- p.z); // ending point of the line
             Gl.glEnd();*/
            // Gl.glRotatef(anguloRotacion, 0, 1, 0); //rotating relative himself
            //Gl.glRotatef(anguloRotacion, 0, 1, 0); //rotating around himself
            Gl.glCallList(list);
            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
        } 
    }
}
