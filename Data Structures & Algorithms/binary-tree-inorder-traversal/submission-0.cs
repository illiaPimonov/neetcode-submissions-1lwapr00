/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> InorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        inorder(root,res);
        return res;
        }
    public void inorder(TreeNode root,List<int> res){
        if(root != null){
            inorder(root.left,res);
            res.Add(root.val);
            inorder(root.right,res);
        }
    }
}