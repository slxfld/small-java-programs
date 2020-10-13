package kps;


import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.util.ArrayList;
import javax.swing.Timer;

class Key implements ActionListener{
    Timer timer;
    boolean delet = false;
    ArrayList<Key> keys;
    int keycode;
    public Key(ArrayList<Key> keys,int _keyc){
        keycode=_keyc;
        this.keys=keys;
        timer = new Timer(1000,this);
        timer.start();
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        timer.stop();
        keys.remove(this);
    }
}