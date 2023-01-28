package com.example.wensql;

import javax.persistence.*;

@Entity
@Table(name = "studenttab")
public class Student {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;
    @Column(name = "sname")
    private String name;
    @Column(name = "scourse")
    private String course;
    @Column(name = "sfee")
    private double fee;

    public long getId() {
        return id;
    }

    public double getFee() {
        return fee;
    }

    public void setFee(double fee) {
        this.fee = fee;
    }

    public String getCourse() {
        return course;
    }

    public void setCourse(String course) {
        this.course = course;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setId(long id) {
        this.id = id;
    }

    @Override
    public String toString() {
        // TODO Auto-generated method stub
        return "Student [id=" + id + ", name=" + name + ", course=" + course + ", fee=" + fee + "]";
    }
}
