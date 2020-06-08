/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kps;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import javax.swing.JPanel;
import javax.swing.Timer;


public class ppanel extends JPanel implements ActionListener{
    Timer timer;
    int values[];
    public ArrayList<Key> keys;
    public int kps;
    public int max;
    public ppanel(){
        timer = new Timer(50,this);
        values=new int[190];
        for(int i=0;i<values.length-1;i++){values[i]=0;}
        timer.start();
    }
    
    @Override
    public void paintComponent(Graphics g){
        super.paintComponent(g);
        g.setColor(Color.red);
        values[190-1] = kps;
        for(int i = 0;i<values.length-1;i++){
           try{ g.fillRect(i+5, 155, 1, -(values[i]*(120/max)) ); }catch(Exception e){}
        }
        g.setColor(Color.black);
        g.drawString("KPS: " + kps, 20, 20);
        double maxd = max;
        g.drawString("top:"+maxd, 160, 20);
        
        
        for(int i = 0; i < values.length-1;i++){
            values[i] = values[i+1];
        }

        
        
    }

    @Override public void actionPerformed(ActionEvent e) {repaint();}
    
}
