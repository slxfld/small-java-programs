
package kps;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFrame;
import static javax.swing.JFrame.EXIT_ON_CLOSE;
import javax.swing.JLabel;
import javax.swing.Timer;
import org.jnativehook.GlobalScreen;
import org.jnativehook.keyboard.NativeKeyEvent;
import org.jnativehook.keyboard.NativeKeyListener;



public class Kps implements NativeKeyListener,ActionListener{

    JFrame frame;
    ppanel panel;
    Timer timer;
    ArrayList<Key> keys;
    JLabel label;
    ArrayList<Integer> actives;
    int max;
    Kps(){
        max=0;
        keys = new ArrayList<>();
        actives = new ArrayList<>();
        frame = new JFrame();
        frame.setSize(215,200);

        panel=new ppanel();
        frame.add(panel);
        
        frame.setDefaultCloseOperation(EXIT_ON_CLOSE);
        frame.setResizable(false);
        frame.setVisible(true);
        
        try{ GlobalScreen.registerNativeHook(); }catch(Exception ex){}
        
        GlobalScreen.addNativeKeyListener(this);
        Logger logger = Logger.getLogger(GlobalScreen.class.getPackage().getName());
        logger.setLevel(Level.WARNING);
        logger.setUseParentHandlers(false);

        timer=new Timer(5,this);
        timer.start();
    }
    
    public static void main(String[] args) {
        Kps s = new Kps();
    }


    @Override
    public void actionPerformed(ActionEvent e) {
        panel.kps = keys.size();
        if(keys.size()>max){max=keys.size(); panel.max=max;}
    }
    
    private boolean check_key_exists(NativeKeyEvent nke){
        for(Integer in : actives){
            if(in.equals(nke.getKeyCode())){
                return true;
            }
        }
        return false;
    }
    
    @Override  public void nativeKeyTyped(NativeKeyEvent nke) {}
    @Override  public void nativeKeyPressed(NativeKeyEvent nke) {
        if(!check_key_exists(nke)){
          keys.add(new Key(keys,nke.getKeyCode()));
          actives.add(nke.getKeyCode());
          System.out.println(""+nke.getKeyCode());
        }
        
    }
    @Override  public void nativeKeyReleased(NativeKeyEvent nke) {
        try{
        for(Integer in : actives){
            if(nke.getKeyCode() == in){
                actives.remove(in);
            }
        }
        }catch(Exception es){}
    }
    
}
