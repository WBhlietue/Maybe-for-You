package com.example.democonsole;

import org.springframework.boot.CommandLineRunner;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ConfigurableApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import org.springframework.core.annotation.Order;
import org.springframework.stereotype.Component;

@Component
@Order(2)
public class Test implements CommandLineRunner {

    @Override
    public void run(String... args) throws Exception {
        ConfigurableApplicationContext cont = new ClassPathXmlApplicationContext("Beans.xml");
        BeanTest test = (BeanTest) cont.getBean("HI");
        System.out.println("\n\n" + test.getMsg() + "\n\n");

        Student st = (Student) cont.getBean("student");
        Salbar sal = (Salbar)cont.getBean("salbar");

        st.setSalbar(sal);
        System.out.println(st);
        
        cont.close();
    }

}
