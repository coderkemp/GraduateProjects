//
//  mainViewController.swift
//  FoodShare
//
//  Created by Heta Gheewala on 4/15/17.
//  Copyright © 2017 Heta Gheewala. All rights reserved.
//

import UIKit

class UserMainVC: UIViewController {

    
    var foodData:[String] = [] //array of strings
    
    override func viewDidLoad() {
        super.viewDidLoad()
         navigationItem.title = "FoodDetails"
 
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    

    
    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = tableView.dequeueReusableCell(withIdentifier: "smurfCell", for: indexPath)
        
        // Configure the cell...
        cell.textLabel?.text = foodData[indexPath.row]
        cell.detailTextLabel?.text = "food Rule!"
        
        
        
        return cell
    }

    
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        let indexPath = tableView.indexPathForSelectedRow
        print("You tapped \(indexPath)")
        
        let smurfName = foodData[indexPath!.row]
        let detailVC = segue.destination 
        detailVC.title = smurfName
        detailVC.nameText = smurfName
    }
    

}
