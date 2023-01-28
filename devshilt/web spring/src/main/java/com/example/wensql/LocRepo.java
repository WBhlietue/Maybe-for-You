package com.example.wensql;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface LocRepo extends  CrudRepository<Location, Integer> {
    
}
