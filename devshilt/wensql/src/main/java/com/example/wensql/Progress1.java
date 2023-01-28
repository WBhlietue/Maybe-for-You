package com.example.wensql;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

@Repository
public class Progress1 {
    @Autowired
    private StudentRepository repo;

    public void CreateStudent(String name, String course, double fee) {
        Student st = new Student();
        st.setName(name);
        st.setCourse(course);
        st.setFee(fee);
        System.out.println(repo);
        repo.save(st);
    }

    public Student FindStudent(long id) {
        Student st = repo.findById(id).get();
        return st;
    }

    public void UpdateStudent(long id, String course) {
        Student st = repo.findById(id).get();
        st.setCourse(course);
        repo.save(st);
    }

    public void DeleteStudent(long id) {
        Student st = repo.findById(id).get();
        repo.delete(st);
    }
    public long Count(){
        return repo.count();
    }
}
