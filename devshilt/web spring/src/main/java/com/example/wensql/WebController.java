package com.example.wensql;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class WebController {

    @Autowired
    Process pro;

    @GetMapping("/location")
    public String Get(Model model) {
        model.addAttribute("value", GetLoc());
        return "test";
    }

    @PostMapping("/location")
    public String Submit(@ModelAttribute Location loc, Model mod, @RequestParam(name = "val") String str,
            @RequestParam(name = "pro") String p) {
        if (p.equals("add")) {
            pro.Add(loc);
            System.out.println(loc);
        } else if (p.equals("delete")) {
            int l = Integer.parseInt(str);
            pro.Delete(l);
        } else if (p.equals("update")) {
            mod.addAttribute("update", GetUpdate(str));
        }else if(p.equals("up")){
            pro.Update(loc);
        }
        mod.addAttribute("value", GetLoc());
        return "test";
    }

    String GetUpdate(String id) {
        String str = "";
        str += "<form  th:action = '@{/location}' th:object = '@{location}' method='post'>" +
                "<input type='hidden' name='val' value='" + id + "'>" +
                "<input type='hidden' name='pro' value='up'>" +
                "<p>" +
                "<label>ID</label>" +
                "<input name = 'id' type='number' value = '" + id + "'>" +
                "</p>" +
                "<p>" +
                "<label>Code</label>" +
                "<input name = 'lcode' type='text'>" +
                "</p>" +
                "<p>" +
                "<label>Name</label>" +
                "<input name = 'lname' type='text'>" +
                "</p>" +
                "<p>" +
                "<label>Type</label>" +
                "<p><input name = 'itype' type='radio'  value='Urban' checked> <label>Urban</label></p>" +
                "<p><input name = 'itype' type='radio'  value='Rural'> <label>Rural</label></p>" +
                "</p>" +
                "<input type='submit' value='Update'>" +
                "</form>";
        return str;
    }

    String GetLoc() {
        List<Location> loc = pro.GetAll();
        String str = "";
        str += "<tr>";
        str += "<td>ID</td>";
        str += "<td>Code</td>";
        str += "<td>Name</td>";
        str += "<td>Type</td>";
        str += "</tr>";
        for (int i = 0; i < loc.size(); i++) {
            String delete = "<form  th:action = '@{/location}' method = 'post'><input type='hidden' name='val' value='"
                    + loc.get(i).getId()
                    + "'> <input type='hidden' name='pro' value='delete'> <input class='f' type = 'submit' value='delete'></form>";
            String update = "<form  th:action = '@{/location}' method = 'post'><input type='hidden' name='val' value='"
                    + loc.get(i).getId()
                    + "'> <input type='hidden' name='pro' value='update'> <input class='f' type = 'submit' value='update'></form>";
            str += "<tr>";
            str += "<td>" + loc.get(i).getId() + "</td>";
            str += "<td>" + loc.get(i).getLcode() + "</td>";
            str += "<td>" + loc.get(i).getLname() + "</td>";
            str += "<td>" + loc.get(i).getItype() + "</td>";
            str += "<td>" + delete + "</td>";
            str += "<td>" + update + "</td>";
            str += "</tr>";
        }
        return str;
    }

}
