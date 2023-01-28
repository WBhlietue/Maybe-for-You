package com.example.wensql;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "location")
public class Location {
    @Id
    private int id;
    @Column(name = "lcode")
    private String lcode;
    @Column(name = "lname")
    private String lname;
    @Column(name = "itype")
    private String ltype;

    public int getId() {
        return id;
    }

    public String getItype() {
        return ltype;
    }

    public void setItype(String type) {
        this.ltype = type;
    }

    public String getLname() {
        return lname;
    }

    public void setLname(String name) {
        this.lname = name;
    }

    public String getLcode() {
        return lcode;
    }

    public void setLcode(String code) {
        this.lcode = code;
    }

    public void setId(int id) {
        this.id = id;
    }

    @Override
    public String toString() {
        return "id = " + id + ", code = " + lcode + ", name = " + lname + ", type = " + ltype ;
    }
}
