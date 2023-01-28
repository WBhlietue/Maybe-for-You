package com.example.wensql;

import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

@Repository
public class Process {
    @Autowired
    private LocRepo repo;

    public void Add(Location loc) {
        repo.save(loc);
    }

    public Location Get(int id) {
        return repo.findById(id).get();
    }

    public List<Location> GetAll() {
        List<Location> list = new ArrayList<>();
        repo.findAll().forEach(list::add);
        return list;
    }

    public void Delete(int id) {
        repo.deleteById(id);
    }

    public void Update(Location loc) {
        int id = loc.getId();
        repo.deleteById(id);
        repo.save(loc);
    }
}
