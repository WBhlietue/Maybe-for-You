package com.example.wensql;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("/book")
public class WebController {
    @GetMapping("test")
    public String Get(Model model){
        System.out.println("122222222222222222222222223123121");
        model.addAttribute("test", "hi yoooo");
        return "test";
    }
}
