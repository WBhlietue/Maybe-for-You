import java.awt.*;
import java.awt.event.*;

import javax.swing.*;
import javax.swing.border.*;

import FrameItem.*;
import Register.*;
import java.util.List;

public class App {
    JFrame home, register, reg, login, mainFrame;

    public static User currentUser;

    public void Home() {
        home = new JFrame("Hotel Del Luna");
        home.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        home.setLayout(null);
        home.setSize(1280, 720);
        JLabel lable = new JLabel("Hotel Del Luna");
        lable.setFont(new Font("Arial", Font.PLAIN, 90));
        lable.setSize(1000, 300);
        lable.setLocation(300, 100);
        home.add(lable);
        HButton btn = new HButton(home, 200, 500, 50, 300, "Register");
        btn.AddListener(new IClickButton() {
            @Override
            public void OnClick() {
                Register();
            }
        });

        HButton btn2 = new HButton(home, 700, 500, 50, 300, "Login");
        btn2.AddListener(new IClickButton() {
            @Override
            public void OnClick() {
                Login();
            }
        });

        home.setVisible(true);
    }

    public void Register() {
        register = new JFrame("Register");
        register.setLayout(null);
        register.setSize(1280, 720);
        InputAndLabel surName = new InputAndLabel(register, 100, 100, 50, 500, "SurName");
        InputAndLabel lastName = new InputAndLabel(register, 100, 225, 50, 500, "LastName");
        InputAndLabel phone = new InputAndLabel(register, 100, 350, 50, 500, "Phone");
        InputAndLabel birthDay = new InputAndLabel(register, 650, 100, 50, 500, "BirthDay (YYYY-MM-DD)");
        InputAndLabel registr = new InputAndLabel(register, 650, 225, 50, 500, "Register");
        InputAndLabel mail = new InputAndLabel(register, 650, 350, 50, 500, "EMail");
        HButton btn = new HButton(register, 400, 500, 75, 500, "Next");
        btn.AddListener(new IClickButton() {
            @Override
            public void OnClick() {
                Reg(new People(surName.GetInputText(), lastName.GetInputText(),
                        Date.FromString(birthDay.GetInputText()), registr.GetInputText(), phone.GetInputText(),
                        mail.GetInputText()));
            }
        });

        register.setVisible(true);
    }

    public void Reg(People p) {
        reg = new JFrame("Register");
        reg.setLayout(null);
        reg.setSize(600, 720);
        InputAndLabel name = new InputAndLabel(reg, 50, 100, 50, 500, "UserName");
        InputAndLabel pass = new InputAndLabel(reg, 50, 225, 50, 500, "Password");
        InputAndLabel rePass = new InputAndLabel(reg, 50, 350, 50, 500, "Re Password");
        JLabel label = new JLabel("");
        label.setLocation(50, 425);
        label.setSize(600, 25);
        reg.add(label);
        HButton btn = new HButton(reg, 50, 500, 75, 500, "Register");
        btn.AddListener(new IClickButton() {
            @Override
            public void OnClick() {
                if (pass.GetInputText().equals(rePass.GetInputText())) {
                    String callBack = UserManager.Register(name.GetInputText(), pass.GetInputText(), p);
                    if (!callBack.equals("complete")) {
                        label.setText(callBack);
                    } else {
                        currentUser = UserManager.FindWithName(name.GetInputText());
                        if (currentUser == null) {
                            System.out.println("user reg error");
                        }
                        DisableFrame();
                    }
                } else {
                    label.setText("password is not mismatch");
                }
            }
        });

        reg.setVisible(true);
    }

    public void Login() {

        reg = new JFrame("Login");
        reg.setLayout(null);
        reg.setSize(600, 720);
        InputAndLabel name = new InputAndLabel(reg, 50, 100, 50, 500, "UserName");
        InputAndLabel pass = new InputAndLabel(reg, 50, 225, 50, 500, "Password");
        JLabel label = new JLabel("");
        label.setLocation(50, 425);
        label.setSize(600, 25);
        reg.add(label);
        HButton btn = new HButton(reg, 50, 500, 75, 500, "Login");
        btn.AddListener(new IClickButton() {
            @Override
            public void OnClick() {
                String callBack = UserManager.Login(name.GetInputText(), pass.GetInputText());
                if (!callBack.equals("login")) {
                    label.setText(callBack);
                } else {
                    currentUser = UserManager.FindWithName(name.GetInputText());
                    if (currentUser == null) {
                        System.out.println("user log error");
                    }
                    DisableFrame();
                }
            }
        });
        reg.setVisible(true);
    }

    public void MainFrame() {
        mainFrame = new JFrame("Main");
        mainFrame.setLayout(null);
        mainFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        mainFrame.setSize(1280, 720);

        Border bor = BorderFactory.createLineBorder(Color.black);
        JLabel l = new JLabel("Rooms");
        l.setSize(1000, 100);
        l.setLocation(575, 0);
        l.setFont(new Font("Arial", Font.PLAIN, 50));
        System.out.println(currentUser);
        JLabel l1 = new JLabel(currentUser.getPeopleName());
        l1.setSize(200, 100);
        l1.setLocation(50, 0);
        l1.setFont(new Font("Arial", Font.PLAIN, 30));
        mainFrame.add(l1);
        JPanel panel = new JPanel();
        panel.setSize(1200, 550);
        panel.setLocation(30, 100);
        panel.setBorder(bor);
        panel.setLayout(new GridLayout(4, 9));
        List<RoomData> data = RoomRegister.GetroomsCopy();
        HButton[] btns = new HButton[36];
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 9; j++) {
                btns[9 * i + j] = new HButton(panel, (i + 1) + "0" + (j + 1));
                btns[9 * i + j].SetFont(new Font("Arial", Font.PLAIN, 20));
                int a = 9 * i + j;
                String r = (i + 1) + "0" + (j + 1);
                btns[9 * i + j].AddListener(new IClickButton() {
                    @Override
                    public void OnClick() {
                        if (data.get(a).getPeople() == null) {
                            RegisterToRoom.Register(r, currentUser.getPeople());
                            btns[a].SetText(
                                    "<html>" + r + "<br />" + currentUser.getPeopleName() + "</html>");
                        } else if (currentUser.checkIsThisPeople(data.get(a).getPeople())) {
                            RegisterToRoom.Remove(r);
                            btns[a].SetText("<html>" + r + "<br />" + "__" + "</html>");
                        }

                    }
                });
            }
        }
        for (int i = 0; i < 36; i++) {
            String p;
            try {
                p = data.get(i).getPeople().getName();
            } catch (Exception e) {
                p = "__";
            }
            btns[i].SetText("<html>" + btns[i].GetText() + "<br />" + p + "</html>");
        }
        mainFrame.add(panel);
        mainFrame.add(l);
        mainFrame.setVisible(true);
    }

    public static void main(String[] args) {
        RoomRegister.Load();
        App app = new App();
        app.Home();
    }

    public void DisableFrame() {
        DisableF(register);
        DisableF(reg);
        DisableF(home);
        DisableF(login);
        MainFrame();
    }

    void DisableF(JFrame f) {
        try {
            f.setVisible(false);
        } catch (Exception e) {

        }
    }
}
