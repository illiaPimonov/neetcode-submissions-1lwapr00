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
    public List<int> PreorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        preorder(root,res);
        return res;
    }
    public void preorder(TreeNode root,List<int> res){
        if(root != null){
        res.Add(root.val);
        preorder(root.left,res);
        preorder(root.right,res);
        }
    }
}